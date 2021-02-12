import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { ScrollView, StyleSheet, Text, View } from 'react-native';

export default function scroll() {
  return (
    <View style={styles.container}>
      <ScrollView>
        <View style={styles.grosCarre}/>
        <ScrollView horizontal={true}>
          <View style={styles.petitCarre}/>
          <View style={styles.petitCarre}/>
          <View style={styles.petitCarre}/>
          <View style={styles.petitCarre}/>
        </ScrollView>
        <View style={styles.grosCarre}/>
        <View style={styles.petitCarre}/>
        <View style={styles.grosCarre}/>
      </ScrollView>
      
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'stretch',
    justifyContent: 'center',
  },
  grosCarre: {
    height: 300,
    margin: 10,
    backgroundColor: 'steelblue'
  },
  petitCarre: {
    height: 200,
    width: 200,
    margin: 10,
    backgroundColor: 'skyblue'
  }
});
