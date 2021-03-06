﻿using System;
using UnityEngine;
using System.Collections.Generic;

public class ChatObjectRight
{
    /// <summary> 右侧对话，没有等待时间 </summary>
    public void Say(View view, string message)
    {
        // 弹出新对话
        view.PopBubble(message, view.m_soundManager.m_rightAudio);
        // 隐藏选择面板
        view.HideChoicePanel();
        view.m_isRightChatIsNull = true;
    }

    public void Choose(View view, Dictionary<string, Action<string>> m_choices)
    {
        if (m_choices.Keys.Count == 2)
        {
            view.m_isRightChatIsNull = false;
            view.SetChoice(m_choices);
        }
        else
        {
            Debug.LogError("选择项数量不为2");
        }
    }
}

public class ChatObjectLeft {
    /// <summary> 左侧对话，有等待时间 </summary>
    public void Say(ChatManager cm, string message)
    {
        cm.m_leftChats.Enqueue(message);
    }
}

