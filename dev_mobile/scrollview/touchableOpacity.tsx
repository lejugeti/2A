import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { FlatList, ScrollView, StyleSheet, Text, TouchableOpacity, View } from 'react-native';


export default function App() {
  
  

  return (
    <View style={styles.container}>
      <TouchableOpacity
        style={styles.btn}
      >
        <Text style={styles.text}>DAMN LES GENS</Text>
      </TouchableOpacity>
      
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
  btn:{
    flex: 0.1,
    width: 200,
    justifyContent: 'center',
    alignItems:'center',
    backgroundColor: 'skyblue'
  },
  text: {
    fontSize: 20,
  }
});
