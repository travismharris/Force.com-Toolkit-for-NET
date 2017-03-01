SFDX_DISABLE_ENCRYPTION=true
CONSUMERKEY=3MVG9i1HRpGLXp.rMUKAGij9Rx1syv9I4m49d6VuaBX8KSJC41fiHdwHFQKS6LpWOUBVskesGxjCv9UzxCHTQ
HUBORG_USERNAME=wade@dxpilot.com

keyfile=/Users/wade.wegner/Projects/Github/WadeWegner/sfdx-travisci-certs/server.key

sfdx force:auth:jwt:grant --clientid $CONSUMERKEY --jwtkeyfile $keyfile --username $HUBORG_USERNAME --setdefaultdevhubusername
sfdx force:org:create -s -f workspace/workspace-scratch-def.json -a ciorg
# sfdx force:org:describe -u ciorg --json

scratchorg_username=`sfdx force:org:describe -u ciorg --json | jq -r .username`
scratchorg_accessToken=`sfdx force:org:describe -u ciorg --json | jq -r .accessToken`
scratchorg_instanceUrl=`sfdx force:org:describe -u ciorg --json | jq -r .instanceUrl`

export USERNAME=$scratchorg_username
export ACCESSTOKEN=$scratchorg_accessToken
export INSTANCEURL=$scratchorg_instanceUrl
export APIVERSION=v36.0

echo $USERNAME
echo $ACCESSTOKEN
echo $INSTANCEURL
echo $APIVERSION