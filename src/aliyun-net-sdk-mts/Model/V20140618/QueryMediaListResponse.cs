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
	public class QueryMediaListResponse : AcsResponse
	{
	    public List<Media> MediaList { get; set; }

	    public List<string> NonExistMediaIds { get; set; }

	    public class Media{
	        public string MediaId { get; set; }

	        public string Title { get; set; }

	        public string Description { get; set; }

	        public string CoverURL { get; set; }

	        public long? CateId { get; set; }

	        public string Duration { get; set; }

	        public string Format { get; set; }

	        public string Size { get; set; }

	        public string Bitrate { get; set; }

	        public string Width { get; set; }

	        public string Height { get; set; }

	        public string Fps { get; set; }

	        public string PublishState { get; set; }

	        public string CreationTime { get; set; }

	        public List<Play> PlayList { get; set; }

	        public List<Snapshot> SnapshotList { get; set; }

	        public List<string> Tags { get; set; }

	        public List<string> RunIdList { get; set; }

	        public File_ File { get; set; }

	        public MediaInfo_ MediaInfo { get; set; }

	        public class Play{
	            public string ActivityName { get; set; }

	            public string MediaWorkflowId { get; set; }

	            public string MediaWorkflowName { get; set; }

	            public string Duration { get; set; }

	            public string Format { get; set; }

	            public string Size { get; set; }

	            public string Bitrate { get; set; }

	            public string Width { get; set; }

	            public string Height { get; set; }

	            public string Fps { get; set; }

	            public File_ File { get; set; }

	            public class File_{
	                public string URL { get; set; }

	                public string State { get; set; }
	            }
			}

			public class Snapshot{
			    public string Type { get; set; }

			    public string MediaWorkflowId { get; set; }

			    public string MediaWorkflowName { get; set; }

			    public string ActivityName { get; set; }

			    public string Count { get; set; }

			    public File_ File { get; set; }

			    public class File_{
			        public string URL { get; set; }

			        public string State { get; set; }
			    }
			}

			public class File_{
			    public string URL { get; set; }

			    public string State { get; set; }
			}

			public class MediaInfo_{
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
		}
	}
}