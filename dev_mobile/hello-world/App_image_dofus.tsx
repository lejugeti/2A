import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { StyleSheet, Text, View, Image } from 'react-native';

export default function bonjour() {
  return (
    <View style={styles.container}>
      <Image source={require('./assets/dofus.jpg')} style={styles.logo}></Image>
      <Image source={require('./assets/dofus.jpg')} style={styles.logo}></Image>
      <Image source={require('./assets/dofus.jpg')} style={styles.logo}></Image>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'flex-end',
    justifyContent: 'space-between'
  },
  logo: {
    flex: 0.2,
    width: 100
  },

  carre: {
    flex: 0.2,
    width: 100,
    margin: 20,    
    borderRadius: 10,
    borderWidth: 2,
    
  },
  rouge:{
    backgroundColor: 'red'
  },
  jaune:{
    backgroundColor: 'yellow'
  },
  vert:{
    backgroundColor: 'green'
  },
  grosTexte: {
    fontSize: 40
  }
});
