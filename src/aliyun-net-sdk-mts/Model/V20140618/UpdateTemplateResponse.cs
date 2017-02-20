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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class UpdateTemplateResponse : AcsResponse
	{
	    public Template_ Template { get; set; }

	    public class Template_{
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

			    public string Remove { get; set; }

			    public string Crop { get; set; }

			    public string Pad { get; set; }

			    public string MaxFps { get; set; }

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

			    public string Remove { get; set; }
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
		}
	}
}