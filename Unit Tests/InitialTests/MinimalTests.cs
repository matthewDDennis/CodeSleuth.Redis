using System.Net.Sockets;

namespace InitialTests
{
    public class MinimalTests
    {
        /// <summary>
        /// This test verifies that a Redis server is running.
        /// </summary>
        [Fact]
        public void RedisIsRunning()
        {
            using var client = new TcpClient("localhost", 6379);
            Assert.True(client.Connected);
        }


        /// <summary>
        /// This test verifies that a connection to the Redis server can be created.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        [Fact]
        public void CreateConnection()
        {
            throw new NotImplementedException("CreateConnection test not implemented");
        }

        /// <summary>
        /// This test verifies that a Client to interact with the Redis server can be created.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        [Fact]
        public void CreateClient()
        {
            throw new NotImplementedException("CreateClient test not implemented");
        }

        /// <summary>
        /// This test verifies that a Client can send a Ping command to the Redis server
        /// and receive the response..
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        [Fact]
        public void CanSendPingAndReceivePong()
        {
            throw new NotImplementedException("CanSendPingAndReceivePong test not implemented");
        }

    }
}