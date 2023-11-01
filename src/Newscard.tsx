import React from 'react';
import { Card, CardMedia, CardContent, Typography } from '@mui/material';

interface LatestNewsCardProps {
  title: string;
  description: string;
  imageUrl: string;
}

const LatestNewsCard: React.FC<LatestNewsCardProps> = ({ title, description, imageUrl }) => {
  return (
    <Card>
      <CardMedia
        component="img"
        height="140"
        image={imageUrl}
        alt={title}
      />
      <CardContent>
        <Typography gutterBottom variant="h5" component="div">
          {title}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {description}
        </Typography>
      </CardContent>
    </Card>
  );
};

export default LatestNewsCard;
