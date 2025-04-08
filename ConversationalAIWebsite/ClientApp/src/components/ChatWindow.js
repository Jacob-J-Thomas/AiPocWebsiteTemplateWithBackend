import React, { useEffect, useState, useRef } from 'react';
import './ChatWindow.css';
import { Message } from './Message';

function ChatWindow({ messages, sendMessage, clearMessages }) {
    const [inputMessage, setInputMessage] = useState('');
    const chatEndRef = useRef(null);

    useEffect(() => {
        // chatEndRef.current?.scrollIntoView({ behavior: 'smooth' });
    }, [messages]);

    const handleSendMessage = () => {
        sendMessage(inputMessage);
        setInputMessage('');
    };

    return (
        <div className="chat-window">
            <div className="message-list">
                {messages.map((msg, index) => (
                    <Message
                        key={index}
                        author={msg.role}
                        content={msg.content}
                        timestamp={msg.timestamp}
                        alignRight={msg.role === "Assistant"}
                    />
                ))}
                <div ref={chatEndRef} />
            </div>
            <div className="chat-input">
                <div className="chat-input-input-container">
                    <label>SQL Conversion Assistant</label>
                    <input
                        type="text"
                        value={inputMessage}
                        onChange={(e) => setInputMessage(e.target.value)}
                        placeholder="Enter a natural language query to convert to SQL..."
                        onKeyDown={(e) => e.key === 'Enter' && handleSendMessage()}
                    />
                </div>
                <button className="toolbar-button" onClick={handleSendMessage}>Convert</button>
                <button className="toolbar-button" onClick={clearMessages}>Reset</button>
            </div>
        </div>
    );
}

export default ChatWindow;
