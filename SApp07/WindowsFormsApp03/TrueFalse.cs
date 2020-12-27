using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp03
{
    class TrueFalse
    {
        private string fileName;
        private List<Question> questionsList;

        public string FileName
        {
            set { fileName = value; }
        }

        public TrueFalse (string fileName)
        {
            this.fileName = fileName;
            questionsList = new List<Question>();
        }

        public void Add(string text, bool trufalse)
        {
            questionsList.Add(new Question(text, trufalse));
        }

        public void Remove(int index)
        {
            if(questionsList != null && index < questionsList.Count && index >= 0)
            {
                questionsList.RemoveAt(index);
            }
        }

        public Question this[int index]
        {
            get { return questionsList[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using(Stream fstream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fstream, questionsList);

            }
        }

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (Stream fstream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                questionsList =  (List<Question>)xmlSerializer.Deserialize(fstream);

            }
        }

        public int Count
        {
            get { return questionsList.Count; }
        }

    }
}
