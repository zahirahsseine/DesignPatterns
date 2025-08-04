    public class Folder(string name) : IComponent
    {
        public string Name => name;

        private readonly List<IComponent> children = new List<IComponent>();
 
        public void Display(string curentPath)
        {
            Console.WriteLine(curentPath + Name + Path.DirectorySeparatorChar);
        }

        public void Add(IComponent child)
        {
             children.Add(child);
        }

        public void Remove(string name)
        {
           var childToRemove = children.FirstOrDefault(c => c.Name == name);

           if (childToRemove is not null)
             children.Remove(childToRemove);
        }

        public void DisplayChildren(string path)
        {
            foreach (var item in children)
            {
                item.Display(path + Name + Path.DirectorySeparatorChar);

                if(item is Folder folder)
                {
                    folder.DisplayChildren(path+ Name + Path.DirectorySeparatorChar);
                }
            }
        }
    }
