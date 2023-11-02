import React from 'react';
import { Collapse } from 'antd';

const { Panel } = Collapse;

interface LoreCardProps {
  title: string;
  content: string;
}

const LoreCard: React.FC<LoreCardProps> = ({ title, content }) => {
  return (
    <Panel header={title} key={title} className="lore-panel">
      <div className="lore-content">{content}</div>
    </Panel>
  );
};

export default LoreCard;
