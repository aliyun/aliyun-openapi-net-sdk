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
	public class ListJobResponse : AcsResponse
	{
	    public string NextPageToken { get; set; }

	    public List<Job> JobList { get; set; }

	    public class Job{
	        public string JobId { get; set; }

	        public string State { get; set; }

	        public string Code { get; set; }

	        public string Message { get; set; }

	        public long? Percent { get; set; }

	        public string PipelineId { get; set; }

	        public string CreationTime { get; set; }

	        public Input_ Input { get; set; }

	        public Output_ Output { get; set; }

	        public MnsMessageResult_ MnsMessageResult { get; set; }

	        public class Input_{
	            public string Bucket { get; set; }

	            public string Location { get; set; }

	            public string Object { get; set; }
	        }

			public class Output_{
			    public string TemplateId { get; set; }

			    public string UserData { get; set; }

			    public string Rotate { get; set; }

			    public string VideoStreamMap { get; set; }

			    public string AudioStreamMap { get; set; }

			    public string DeWatermark { get; set; }

			    public string Priority { get; set; }

			    public List<WaterMark> WaterMarkList { get; set; }

			    public List<Merge> MergeList { get; set; }

			    public OutputFile_ OutputFile { get; set; }

			    public Properties_ Properties { get; set; }

			    public Clip_ Clip { get; set; }

			    public SuperReso_ SuperReso { get; set; }

			    public SubtitleConfig_ SubtitleConfig { get; set; }

			    public TransConfig_ TransConfig { get; set; }

			    public MuxConfig_ MuxConfig { get; set; }

			    public Audio_ Audio { get; set; }

			    public Video_ Video { get; set; }

			    public Container_ Container { get; set; }

			    public class WaterMark{
			        public string WaterMarkTemplateId { get; set; }

			        public string Width { get; set; }

			        public string Height { get; set; }

			        public string Dx { get; set; }

			        public string Dy { get; set; }

			        public string ReferPos { get; set; }

			        public string Type { get; set; }

			        public InputFile_ InputFile { get; set; }

			        public class InputFile_{
			            public string Bucket { get; set; }

			            public string Location { get; set; }

			            public string Object { get; set; }
			        }
				}

				public class Merge{
				    public string MergeURL { get; set; }

				    public string Start { get; set; }

				    public string Duration { get; set; }
				}

				public class OutputFile_{
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

				public class Clip_{
				    public TimeSpan_ TimeSpan { get; set; }

				    public class TimeSpan_{
				        public string Seek { get; set; }

				        public string Duration { get; set; }
				    }
				}

				public class SuperReso_{
				    public string IsHalfSample { get; set; }
				}

				public class SubtitleConfig_{
				    public List<Subtitle> SubtitleList { get; set; }

				    public List<ExtSubtitle> ExtSubtitleList { get; set; }

				    public class Subtitle{
				        public string Map { get; set; }
				    }

					public class ExtSubtitle{
					    public Input_ Input { get; set; }

					    public class Input_{
					        public string Bucket { get; set; }

					        public string Location { get; set; }

					        public string Object { get; set; }
					    }
					}
				}

				public class TransConfig_{
				    public string TransMode { get; set; }

				    public string IsCheckReso { get; set; }

				    public string IsCheckResoFail { get; set; }

				    public string IsCheckVideoBitrate { get; set; }

				    public string IsCheckAudioBitrate { get; set; }

				    public string AdjDarMethod { get; set; }
				}

				public class MuxConfig_{
				    public Segment_ Segment { get; set; }

				    public Gif_ Gif { get; set; }

				    public class Segment_{
				        public string Duration { get; set; }
				    }

					public class Gif_{
					    public string Loop { get; set; }

					    public string FinalDelay { get; set; }

					    public string IsCustomPalette { get; set; }

					    public string DitherMode { get; set; }
					}
				}

				public class Audio_{
				    public string Codec { get; set; }

				    public string Profile { get; set; }

				    public string Samplerate { get; set; }

				    public string Bitrate { get; set; }

				    public string Channels { get; set; }

				    public string Qscale { get; set; }
				}

				public class Video_{
				    public string Codec { get; set; }

				    public string Profile { get; set; }

				    public string Bitrate { get; set; }

				    public string Crf { get; set; }

				    public string Width { get; set; }

				    public string Height { get; set; }

				    public string Fps { get; set; }

				    public string Gop { get; set; }

				    public string Preset { get; set; }

				    public string ScanMode { get; set; }

				    public string Bufsize { get; set; }

				    public string Maxrate { get; set; }

				    public string PixFmt { get; set; }

				    public string Degrain { get; set; }

				    public string Qscale { get; set; }

				    public string Crop { get; set; }

				    public string Pad { get; set; }

				    public string MaxFps { get; set; }

				    public BitrateBnd_ BitrateBnd { get; set; }

				    public class BitrateBnd_{
				        public string Max { get; set; }

				        public string Min { get; set; }
				    }
				}

				public class Container_{
				    public string Format { get; set; }
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