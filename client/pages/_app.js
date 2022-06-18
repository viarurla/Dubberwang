import { ChakraProvider } from '@chakra-ui/react'

function MyApp({ Component, pageProps }) {
  return (
      // Chakra is familiar and elegant, so was a no-brainer to me.
      <ChakraProvider>
        <Component {...pageProps} />
      </ChakraProvider>
  )
}

export default MyApp
