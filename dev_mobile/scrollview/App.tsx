import { StatusBar } from 'expo-status-bar';
import React, { useState } from 'react';
import { FlatList, ScrollView, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';


export default function App() {
  const [nom, setNom] = useState('');
  

  return (
    <View style={styles.container}>
      <TextInput
        placeholder='Saisissez votre prénom'
        onChangeText={text => setNom(text)}
      ></TextInput>
      <Text>Bonjour {nom}</Text>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
  
});
