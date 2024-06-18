import pathlib
import string
import sqlite_utils
import sys
import re

COUNT_TEMPLATE = "<!-- count -->{}<!-- count -->"

root = pathlib.Path(__file__).parent.resolve()
index_re = re.compile(r"<!\-\- index starts \-\->.*<!\-\- index ends \-\->", re.DOTALL)
count_re = re.compile(r"<!\-\- count \-\->.*<!\-\- count \-\->", re.DOTALL)

if __name__ == "__main__":
    db = sqlite_utils.Database(root / "problems.db")
    by_topic = {}
    index = ["<!-- index starts -->"]
    index.append("## Easy")
    for row in db["problems"].rows_where(where="topic2 = 'Easy'", order_by="created_utc"):
        by_topic.setdefault(row["topic3"], []).append(row)
    for topic, rows in by_topic.items():
        index.append("### {}\n".format(topic))
        for row in rows:
            index.append(
                "* [{formattedTitle}]({url}) - {date}".format(
                    formattedTitle=re.sub(r'(?<=[a-z])(?=[A-Z])', ' ', row["title"].replace("-", " ")).title(),
                    date=row["created"].split("T")[0], **row
                )
            )
        index.append("")
    by_topic = {}
    index.append("## Medium")
    for row in db["problems"].rows_where(where="topic2 = 'Medium'", order_by="created_utc"):
        by_topic.setdefault(row["topic3"], []).append(row)
    for topic, rows in by_topic.items():
        index.append("### {}\n".format(topic))
        for row in rows:
            index.append(
                "* [{formattedTitle}]({url}) - {date}".format(
                    formattedTitle=re.sub(r'(?<=[a-z])(?=[A-Z])', ' ', row["title"].replace("-", " ")).title(),
                    date=row["created"].split("T")[0], **row
                )
            )
        index.append("")
    by_topic = {}
    index.append("## Hard")
    for row in db["problems"].rows_where(where="topic2 = 'Hard'", order_by="created_utc"):
        by_topic.setdefault(row["topic3"], []).append(row)
    for topic, rows in by_topic.items():
        index.append("### {}\n".format(topic))
        for row in rows:
            index.append(
                "* [{formattedTitle}]({url}) - {date}".format(
                    formattedTitle=re.sub(r'(?<=[a-z])(?=[A-Z])', ' ', row["title"].replace("-", " ")).title(),
                    date=row["created"].split("T")[0], **row
                )
            )
        index.append("")
    # for row in db["problems"].rows_where(where="topic2 = 'Easy'",order_by="created_utc desc limit 1000"):
    #     index.append(
    #         "* **{topic}** - {title}- *last updated at {date}*".format(
    #             topic=row["topic1"].capitalize(),
    #             title=string.capwords(row["title"].replace("-", " ")),
    #             date=row["updated"].split("T")[0]
    #         )
    #     )
    if index[-1] == "":
        index.pop()
    index.append("<!-- index ends -->")
    if "--rewrite" in sys.argv:
        readme = root / "README.md"
        index_txt = "\n".join(index).strip()
        readme_contents = readme.open().read()
        rewritten = index_re.sub(index_txt, readme_contents)
        rewritten = count_re.sub(COUNT_TEMPLATE.format(db["problems"].count), rewritten)
        readme.open("w").write(rewritten)
    else:
        print("\n".join(index))