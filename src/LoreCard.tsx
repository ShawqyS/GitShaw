import React, { useState } from 'react';
import './App.css'; // Make sure to create a CSS file for LoreCard specific styles

interface LoreCardProps {
  title: string;
  content: string;
}

const LoreCard: React.FC<LoreCardProps> = ({ title, content }) => {
  const [isOpen, setIsOpen] = useState(false);

  const toggleCollapse = () => {
    setIsOpen(!isOpen);
  };

  return (
    <div className="lore-card">
      <div className="lore-card-header" onClick={toggleCollapse}>
        {title}
      </div>
      {isOpen && (
        <div className="lore-card-content">
          <p dangerouslySetInnerHTML={{ __html: content }} />
        </div>
      )}
    </div>
  );
};

export default LoreCard;
