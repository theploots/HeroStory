namespace HeroStory
{
    public class player
    {
        //here we define the player attributes
        private string name = string.Empty;
        private string skill = string.Empty;
        private string origins = string.Empty;
        private int vitality = 100;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Skill
        {
            get { return skill; }
            set { skill = value; }
        }

        public string Origins
        {
            get { return origins; }
            set { origins = value; }
        }

        public int Vitality
        {
            get { return vitality; }
            set { vitality = value; }
        }



    }
    public class FightScene
    {
        public enum SceneType { Fire, Water, Pulse, Force, Magic }

        public SceneType Type { get; private set; }
        public string Description { get; private set; }




        public FightScene(SceneType type, string description)
        {
            Type = type;
            Description = description;

        }


    }



}















