using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetVideoInfo()
    {
return $"Title: {_title}, Author: {_author}, Length: {_length} seconds, Number of Comments: {GetNumberOfComments()}";    }
}