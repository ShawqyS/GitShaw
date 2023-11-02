import { Container, Text } from '@mantine/core';

function Header() {
    return (
      <Container size="lg" style={{ marginTop: 20 }}>
        <Text style={{ textAlign: 'center' }} size="xxl">
          League of Legends Champions
        </Text>
      </Container>
    );
  }
  
export default Header;
