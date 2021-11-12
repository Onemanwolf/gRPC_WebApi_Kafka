curl --silent --output docker-compose.yml https://raw.githubusercontent.com/confluentinc/cp-all-in-one/6.2.1-post/cp-all-in-one/docker-compose.yml

# Bring up Kafka
docker-compose -up -d
# Bring Kafka down 
docker-compose down

