import axios from 'axios';

const axiosInstance = axios.create({
  baseURL: 'http://localhost:5176',
});

export async function getFunctionTemplate(url, errorMessage) {
  try {
    const response = await axiosInstance.get(url);
    console.log(url, "response", response.data);
    return response.data;
  } catch (error) {
    console.error(errorMessage);
    return null;
  }
}

export async function postFunctionTemplate(url, body, errorMessage) {
  try {
    const response = await axiosInstance.post(url, body);
    console.log(url, "response", response.data);
    return response.data;
  } catch (error) {
    console.error(errorMessage);
    return null;
  }
}
