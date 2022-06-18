import Head from 'next/head'
import useSWR, {mutate} from 'swr'
import {
    Box,
    Button,
    Center,
    Stack,
    Text, VStack,
    Wrap,
    WrapItem
} from "@chakra-ui/react";
import LotteryBallDock from "../components/LotteryBallDock";

const fetcher = (...args) => fetch(...args).then((res) => res.json())

const Home = () => {

    // Using HTTP would not be my choice in production.
    // Additionally, this would not be hardcoded here
    let {data, error} = useSWR('http://localhost:7040/api/Lottery', fetcher);

    // Function to determine if the current number array is numberwang
    const isNumberWang = () => {
        let randNum = Math.round(Math.floor(Math.random() * 10));
        // This is literally nonsense
        return randNum === 4;
    }

    const newNumbers = () => {
        return mutate('http://localhost:7040/api/Lottery')
    }

    if (error) return <div>Failed to load</div>
    if (!data) return <div>Loading...</div>

    return (
        <Box>
          <Head>
            <title>Dubberwang</title>
            <meta name="description" content="Dubberwang lottery system" />
            <link rel="icon" href="/favicon.ico" />
          </Head>
          <main>
              <Stack direction='column' margin={10}>
                  <Box
                      display='flex'
                      justifyContent='center'
                      width='100%'
                      py={12}
                      bgPosition='center'
                      bgRepeat='no-repeat'
                      mb={2}
                  >
                      <VStack>
                          {isNumberWang() &&
                              <Text fontSize={"20px"} fontWeight={"bold"}>
                                  {"That's numberwang!"}
                              </Text>
                          }
                      <LotteryBallDock balls={data}/>
                      </VStack>
                  </Box>
                  <Center>
                      <Wrap spacing={4}>
                          <WrapItem>
                              <Button onClick={() => newNumbers()} colorScheme='gray'>
                                  <Text>{"Let's go!"}</Text>
                              </Button>
                          </WrapItem>
                      </Wrap>
                  </Center>
              </Stack>
          </main>
          <footer>
          </footer>
        </Box>
    )
}

export default Home;
