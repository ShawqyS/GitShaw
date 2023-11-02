import { Container, Text } from '@mantine/core';

function Header() {
  return (
    <header className="header">
      <Container size="lg">
        <Text className="header-title" size="xxl">
          League of Legends Champions
        </Text>
      </Container>
    </header>
  );
}

export default Header;
