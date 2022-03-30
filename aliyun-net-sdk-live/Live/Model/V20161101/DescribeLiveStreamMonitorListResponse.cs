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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeLiveStreamMonitorListResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeLiveStreamMonitorList_LiveStreamMonitorInfo> liveStreamMonitorList;

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<DescribeLiveStreamMonitorList_LiveStreamMonitorInfo> LiveStreamMonitorList
		{
			get
			{
				return liveStreamMonitorList;
			}
			set	
			{
				liveStreamMonitorList = value;
			}
		}

		public class DescribeLiveStreamMonitorList_LiveStreamMonitorInfo
		{

			private int? status;

			private string startTime;

			private string monitorId;

			private string domain;

			private string outputTemplate;

			private string region;

			private int? audioFrom;

			private string monitorName;

			private string stopTime;

			private List<DescribeLiveStreamMonitorList_InputConfig> inputList;

			private DescribeLiveStreamMonitorList_OutputUrls outputUrls;

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string MonitorId
			{
				get
				{
					return monitorId;
				}
				set	
				{
					monitorId = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
				}
			}

			public string OutputTemplate
			{
				get
				{
					return outputTemplate;
				}
				set	
				{
					outputTemplate = value;
				}
			}

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public int? AudioFrom
			{
				get
				{
					return audioFrom;
				}
				set	
				{
					audioFrom = value;
				}
			}

			public string MonitorName
			{
				get
				{
					return monitorName;
				}
				set	
				{
					monitorName = value;
				}
			}

			public string StopTime
			{
				get
				{
					return stopTime;
				}
				set	
				{
					stopTime = value;
				}
			}

			public List<DescribeLiveStreamMonitorList_InputConfig> InputList
			{
				get
				{
					return inputList;
				}
				set	
				{
					inputList = value;
				}
			}

			public DescribeLiveStreamMonitorList_OutputUrls OutputUrls
			{
				get
				{
					return outputUrls;
				}
				set	
				{
					outputUrls = value;
				}
			}

			public class DescribeLiveStreamMonitorList_InputConfig
			{

				private int? index;

				private string inputUrl;

				private int? layoutId;

				private string streamName;

				private DescribeLiveStreamMonitorList_LayoutConfig layoutConfig;

				private DescribeLiveStreamMonitorList_PlayConfig playConfig;

				public int? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string InputUrl
				{
					get
					{
						return inputUrl;
					}
					set	
					{
						inputUrl = value;
					}
				}

				public int? LayoutId
				{
					get
					{
						return layoutId;
					}
					set	
					{
						layoutId = value;
					}
				}

				public string StreamName
				{
					get
					{
						return streamName;
					}
					set	
					{
						streamName = value;
					}
				}

				public DescribeLiveStreamMonitorList_LayoutConfig LayoutConfig
				{
					get
					{
						return layoutConfig;
					}
					set	
					{
						layoutConfig = value;
					}
				}

				public DescribeLiveStreamMonitorList_PlayConfig PlayConfig
				{
					get
					{
						return playConfig;
					}
					set	
					{
						playConfig = value;
					}
				}

				public class DescribeLiveStreamMonitorList_LayoutConfig
				{

					private string fillMode;

					private string positionRefer;

					private List<string> positionNormalized;

					private List<string> sizeNormalized;

					public string FillMode
					{
						get
						{
							return fillMode;
						}
						set	
						{
							fillMode = value;
						}
					}

					public string PositionRefer
					{
						get
						{
							return positionRefer;
						}
						set	
						{
							positionRefer = value;
						}
					}

					public List<string> PositionNormalized
					{
						get
						{
							return positionNormalized;
						}
						set	
						{
							positionNormalized = value;
						}
					}

					public List<string> SizeNormalized
					{
						get
						{
							return sizeNormalized;
						}
						set	
						{
							sizeNormalized = value;
						}
					}
				}

				public class DescribeLiveStreamMonitorList_PlayConfig
				{

					private float? volumeRate;

					public float? VolumeRate
					{
						get
						{
							return volumeRate;
						}
						set	
						{
							volumeRate = value;
						}
					}
				}
			}

			public class DescribeLiveStreamMonitorList_OutputUrls
			{

				private string flvUrl;

				private string rtmpUrl;

				public string FlvUrl
				{
					get
					{
						return flvUrl;
					}
					set	
					{
						flvUrl = value;
					}
				}

				public string RtmpUrl
				{
					get
					{
						return rtmpUrl;
					}
					set	
					{
						rtmpUrl = value;
					}
				}
			}
		}
	}
}
