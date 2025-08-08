var rootFolder = new Folder("Root");

rootFolder.Add(new Folder("Folder1"));
rootFolder.Add(new Folder("Folder2"));

var compositeFolder = new Folder("Folder 3");

compositeFolder.Add(new File("file1.xml"));
compositeFolder.Add(new File("file2.xml"));

rootFolder.Add(compositeFolder);

rootFolder.DisplayChildren(string.Empty);
