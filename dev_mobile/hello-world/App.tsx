import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { StyleSheet, Text, View, Image, ScrollView } from 'react-native';

export default function App() {
  return (
    <View style={styles.container}>
      <ScrollView>
        <View style={styles.grosCarre}/>
        <View style={styles.grosCarre}/>
      </ScrollView>
    </View>
    
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center'
  },

  grosCarre: {
    flex: 1,
    width:200,
    backgroundColor: 'steelblue'
  },
  
});
