FROM $DOCKERIMAGE

RUN apt-get -y update &&\
    apt-get install -y curl

WORKDIR /app
COPY /publish .

EXPOSE 443

CMD ["dotnet", "$ENTRYPOINT"]