import { Card, Text } from '@mantine/core';

interface ChampionCardProps {
  name: string;
  title: string;
  imageUrl: string;
}

function ChampionCard({ name, title, imageUrl }: ChampionCardProps) {
  return (
    <Card style={{ width: 200, margin: 10 }}>
      <img src={imageUrl} alt={name} style={{ width: '100%' }} />
      <Text style={{ textAlign: 'center', marginTop: 10}} size='xl'>{name}</Text>
      <Text style={{ textAlign: 'center', marginTop: 5}} size='sm'>{title}</Text>
    </Card>
  );
}



export default ChampionCard;
