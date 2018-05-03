# Download the Ruby helper library from twilio.com/docs/libraries/ruby
require 'twilio-ruby'

# Get your Account Sid and Auth Token from https://www.twilio.com/console
api_key_sid = 'SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
api_key_secret = 'your_api_key_secret'

client = Twilio::REST::Client.new api_key_sid, api_key_secret

recordings_in_room = client.video.recordings.list(
  grouping_sid: ['RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXX']
)

recordings_in_room.each do |recording|
  puts recording.sid
end