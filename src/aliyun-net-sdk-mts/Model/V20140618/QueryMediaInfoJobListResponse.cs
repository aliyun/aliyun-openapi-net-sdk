/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryMediaInfoJobListResponse : AcsResponse
	{
	    public List<MediaInfoJob> MediaInfoJobList { get; set; }

	    public List<string> NonExistMediaInfoJobIds { get; set; }

	    public class MediaInfoJob{
	        public string JobId { get; set; }

	        public string UserData { get; set; }

	        public string PipelineId { get; set; }

	        public string State { get; set; }

	        public string Code { get; set; }

	        public string Message { get; set; }

	        public string CreationTime { get; set; }

	        public Input_ Input { get; set; }

	        public Properties_ Properties { get; set; }

	        public MnsMessageResult_ MnsMessageResult { get; set; }

	        public class Input_{
	            public string Bucket { get; set; }

	            public string Location { get; set; }

	            public string Object { get; set; }
	        }

			public class Properties_{
			    public string Width { get; set; }

			    public string Height { get; set; }

			    public string Bitrate { get; set; }

			    public string Duration { get; set; }

			    public string Fps { get; set; }

			    public string FileSize { get; set; }

			    public string FileFormat { get; set; }

			    public Streams_ Streams { get; set; }

			    public Format_ Format { get; set; }

			    public class Streams_{
			        public List<VideoStream> VideoStreamList { get; set; }

			        public List<AudioStream> AudioStreamList { get; set; }

			        public List<SubtitleStream> SubtitleStreamList { get; set; }

			        public class VideoStream{
			            public string Index { get; set; }

			            public string CodecName { get; set; }

			            public string CodecLongName { get; set; }

			            public string Profile { get; set; }

			            public string CodecTimeBase { get; set; }

			            public string CodecTagString { get; set; }

			            public string CodecTag { get; set; }

			            public string Width { get; set; }

			            public string Height { get; set; }

			            public string HasBFrames { get; set; }

			            public string Sar { get; set; }

			            public string Dar { get; set; }

			            public string PixFmt { get; set; }

			            public string Level { get; set; }

			            public string Fps { get; set; }

			            public string AvgFps { get; set; }

			            public string Timebase { get; set; }

			            public string StartTime { get; set; }

			            public string Duration { get; set; }

			            public string Bitrate { get; set; }

			            public string NumFrames { get; set; }

			            public string Lang { get; set; }

			            public string Rotate { get; set; }

			            public NetworkCost_ NetworkCost { get; set; }

			            public class NetworkCost_{
			                public string PreloadTime { get; set; }

			                public string CostBandwidth { get; set; }

			                public string AvgBitrate { get; set; }
			            }
					}

					public class AudioStream{
					    public string Index { get; set; }

					    public string CodecName { get; set; }

					    public string CodecTimeBase { get; set; }

					    public string CodecLongName { get; set; }

					    public string CodecTagString { get; set; }

					    public string CodecTag { get; set; }

					    public string SampleFmt { get; set; }

					    public string Samplerate { get; set; }

					    public string Channels { get; set; }

					    public string ChannelLayout { get; set; }

					    public string Timebase { get; set; }

					    public string StartTime { get; set; }

					    public string Duration { get; set; }

					    public string Bitrate { get; set; }

					    public string NumFrames { get; set; }

					    public string Lang { get; set; }
					}

					public class SubtitleStream{
					    public string Index { get; set; }

					    public string Lang { get; set; }
					}
				}

				public class Format_{
				    public string NumStreams { get; set; }

				    public string NumPrograms { get; set; }

				    public string FormatName { get; set; }

				    public string FormatLongName { get; set; }

				    public string StartTime { get; set; }

				    public string Duration { get; set; }

				    public string Size { get; set; }

				    public string Bitrate { get; set; }
				}
			}

			public class MnsMessageResult_
            {
			    public string MessageId { get; set; }

			    public string ErrorMessage { get; set; }

			    public string ErrorCode { get; set; }
			}
		}
	}
}