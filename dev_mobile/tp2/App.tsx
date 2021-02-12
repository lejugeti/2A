import { StatusBar } from 'expo-status-bar';
import React, {useState} from 'react';
import { StyleSheet, Text, View, TextInput, Image, TouchableOpacity, Alert } from 'react-native';
import Authform from './components/Authform';

export default function App() {  

  return (
    <View style={styles.container}>

      <Authform></Authform>
      
      <StatusBar style="auto" />
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
  inputGroup:{
    flex: 0.15,
    flexDirection: 'row',
    alignItems: 'center',
    width: 200,
    borderRadius: 30,
    borderWidth: 2,
    borderColor: 'gray',
    margin: 10
  },
  input:{
    flex: 4,
  },
  inputLogo:{
    flex: 1,
    height: 30,
    width: 30
  },
  logo:{
    height: 100,
    width: 100
  },
  inputComponents:{
    margin: 10
  },
  btn: {
    flex: 0.1,
    width:200,
    justifyContent:'center',
    alignItems: 'center',
    backgroundColor: 'skyblue',
    borderRadius: 30,
    margin:10
  },
  link: {
    flex: 0.1,
    width:200,
    justifyContent:'center',
    alignItems: 'center',
    color: 'black'
  }
});
