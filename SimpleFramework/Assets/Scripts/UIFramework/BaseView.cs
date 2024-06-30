using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IView
{
    void Init();
    void Show();
    void Hide();
};

public class BaseView : MonoBehaviour, IView
{
	public void Init()
	{
		throw new System.NotImplementedException();
	}

	public void Show()
	{
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}

