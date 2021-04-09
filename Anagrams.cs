public bool IsAnagram(string phrase1,string phrase2)
{
  if (phrase1.Length != pharse2.Length)
     return false;
  var phrase1Array = phrase1.ToLower().ToCharArray();
  var phrase2Array = phrase2.ToLower().ToCharArray();

  Array.Sort(phrase1Array);
  Array.Sort(phrase2Array);

  phrase1 = new string(phrase1Array);
  phrase2 = new string(phrase2Array);

  return phrase1 == phrase2;
}
