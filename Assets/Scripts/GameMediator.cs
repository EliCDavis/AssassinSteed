using UnityEngine;
using System.Xml;

namespace AssassinSteed
{
    public class GameMediator
    {
        
        private static GameMediator instance = null;
        public static GameMediator GetInstance()
        {
            if(instance == null)
            {
                instance = new GameMediator();
            }
            return instance;
        }

        private GameMediator()
        {

        }


        /// <summary>
        /// Attempts to load a level from an XML file.
        /// </summary>
        /// <param name="fileName">The file to load the level from</param>
        /// <returns>Whether or not we are succesful loading the file</returns>
        public bool LoadLevel(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            try
            { 
                doc.Load("Levels/test.xml"); 
                Debug.Log(doc.DocumentElement.OuterXml);
                return true;
            }
            catch (System.IO.FileNotFoundException)
            {
                return false;
                Debug.Log("Unable To Find File: " + fileName);
            }

        }

    }
}