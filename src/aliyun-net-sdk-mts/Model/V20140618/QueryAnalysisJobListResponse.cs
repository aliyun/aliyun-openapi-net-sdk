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
	public class QueryAnalysisJobListResponse : AcsResponse
	{
	    public List<AnalysisJob> AnalysisJobList { get; set; }

	    public List<string> NonExistAnalysisJobIds { get; set; }

	    public class AnalysisJob{
	        public string Id { get; set; }

	        public string UserData { get; set; }

	        public string State { get; set; }

	        public string Code { get; set; }

	        public string Message { get; set; }

	        public long? Percent { get; set; }

	        public string CreationTime { get; set; }

	        public string PipelineId { get; set; }

	        public string Priority { get; set; }

	        public List<Template> TemplateList { get; set; }

	        public InputFile_ InputFile { get; set; }

	        public AnalysisConfig_ AnalysisConfig { get; set; }

	        public MnsMessageResult_ MnsMessageResult { get; set; }

	        public class Template{
	            public string Id { get; set; }

	            public string Name { get; set; }

	            public string State { get; set; }

	            public Container_ Container { get; set; }

	            public Video_ Video { get; set; }

	            public Audio_ Audio { get; set; }

	            public TransConfig_ TransConfig { get; set; }

	            public MuxConfig_ MuxConfig { get; set; }

	            public class Container_{
	                public string Format { get; set; }
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

				    public BitrateBnd_ BitrateBnd { get; set; }

				    public class BitrateBnd_{
				        public string Max { get; set; }

				        public string Min { get; set; }
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

				public class TransConfig_{
				    public string TransMode { get; set; }
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
					}
				}
			}

			public class InputFile_{
			    public string Bucket { get; set; }

			    public string Location { get; set; }

			    public string Object { get; set; }
			}

			public class AnalysisConfig_{
			    public QualityControl_ QualityControl { get; set; }

			    public PropertiesControl_ PropertiesControl { get; set; }

			    public class QualityControl_{
			        public string RateQuality { get; set; }

			        public string MethodStreaming { get; set; }
			    }

				public class PropertiesControl_{
				    public string Deinterlace { get; set; }

				    public Crop_ Crop { get; set; }

				    public class Crop_{
				        public string Mode { get; set; }

				        public string Width { get; set; }

				        public string Height { get; set; }

				        public string Top { get; set; }

				        public string Left { get; set; }
				    }
				}
			}

			public class MnsMessageResult_{
			    public string MessageId { get; set; }

			    public string ErrorMessage { get; set; }

			    public string ErrorCode { get; set; }
			}
		}
	}
}