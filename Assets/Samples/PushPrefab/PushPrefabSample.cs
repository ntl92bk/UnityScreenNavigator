using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Modal;
using UnityScreenNavigator.Runtime.Core.Page;

public class PushPrefabSample : MonoBehaviour
{
    [SerializeField] PageContainer _pageContainer;
    [SerializeField] ModalContainer _modalContainer;
    [SerializeField] GameObject _pagePrefab;
    [SerializeField] GameObject _modalPrefab;

    [ContextMenu("Push Page")]
    public void PushPage()
    {
        _pageContainer.Push<Page>(_pagePrefab, true);
    }

    [ContextMenu("Pop Page")]
    public void PopPage()
    {
        _pageContainer.Pop(true);
    }

    [ContextMenu("Push Modal")]
    public void PushModal()
    {
        _modalContainer.Push<Modal>(_modalPrefab, false);
    }

    [ContextMenu("Pop Modal")]
    public void PopModal()
    {
        _modalContainer.Pop(false);
    }
}
