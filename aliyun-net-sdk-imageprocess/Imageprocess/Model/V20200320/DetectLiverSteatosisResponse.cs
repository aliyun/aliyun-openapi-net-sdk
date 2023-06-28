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

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class DetectLiverSteatosisResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private DetectLiverSteatosis_Data data;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public DetectLiverSteatosis_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DetectLiverSteatosis_Data
		{

			private List<DetectLiverSteatosis_DetectionsItem> detections;

			private List<string> spacing;

			private List<string> origin;

			public List<DetectLiverSteatosis_DetectionsItem> Detections
			{
				get
				{
					return detections;
				}
				set	
				{
					detections = value;
				}
			}

			public List<string> Spacing
			{
				get
				{
					return spacing;
				}
				set	
				{
					spacing = value;
				}
			}

			public List<string> Origin
			{
				get
				{
					return origin;
				}
				set	
				{
					origin = value;
				}
			}

			public class DetectLiverSteatosis_DetectionsItem
			{

				private long? radius;

				private float? liverSlice;

				private float? spleenSlice;

				private float? liverVolume;

				private float? spleenVolume;

				private float? liverHU;

				private float? spleenHU;

				private float? liverROI1;

				private float? liverROI2;

				private float? liverROI3;

				private float? spleenROI;

				private float? liverSpleenDifference;

				private float? liverSpleenRatio;

				private string prediction;

				private float? probability;

				private List<string> rOI1Center;

				private List<string> rOI2Center;

				private List<string> rOI3Center;

				private List<string> spleenCenter;

				public long? Radius
				{
					get
					{
						return radius;
					}
					set	
					{
						radius = value;
					}
				}

				public float? LiverSlice
				{
					get
					{
						return liverSlice;
					}
					set	
					{
						liverSlice = value;
					}
				}

				public float? SpleenSlice
				{
					get
					{
						return spleenSlice;
					}
					set	
					{
						spleenSlice = value;
					}
				}

				public float? LiverVolume
				{
					get
					{
						return liverVolume;
					}
					set	
					{
						liverVolume = value;
					}
				}

				public float? SpleenVolume
				{
					get
					{
						return spleenVolume;
					}
					set	
					{
						spleenVolume = value;
					}
				}

				public float? LiverHU
				{
					get
					{
						return liverHU;
					}
					set	
					{
						liverHU = value;
					}
				}

				public float? SpleenHU
				{
					get
					{
						return spleenHU;
					}
					set	
					{
						spleenHU = value;
					}
				}

				public float? LiverROI1
				{
					get
					{
						return liverROI1;
					}
					set	
					{
						liverROI1 = value;
					}
				}

				public float? LiverROI2
				{
					get
					{
						return liverROI2;
					}
					set	
					{
						liverROI2 = value;
					}
				}

				public float? LiverROI3
				{
					get
					{
						return liverROI3;
					}
					set	
					{
						liverROI3 = value;
					}
				}

				public float? SpleenROI
				{
					get
					{
						return spleenROI;
					}
					set	
					{
						spleenROI = value;
					}
				}

				public float? LiverSpleenDifference
				{
					get
					{
						return liverSpleenDifference;
					}
					set	
					{
						liverSpleenDifference = value;
					}
				}

				public float? LiverSpleenRatio
				{
					get
					{
						return liverSpleenRatio;
					}
					set	
					{
						liverSpleenRatio = value;
					}
				}

				public string Prediction
				{
					get
					{
						return prediction;
					}
					set	
					{
						prediction = value;
					}
				}

				public float? Probability
				{
					get
					{
						return probability;
					}
					set	
					{
						probability = value;
					}
				}

				public List<string> ROI1Center
				{
					get
					{
						return rOI1Center;
					}
					set	
					{
						rOI1Center = value;
					}
				}

				public List<string> ROI2Center
				{
					get
					{
						return rOI2Center;
					}
					set	
					{
						rOI2Center = value;
					}
				}

				public List<string> ROI3Center
				{
					get
					{
						return rOI3Center;
					}
					set	
					{
						rOI3Center = value;
					}
				}

				public List<string> SpleenCenter
				{
					get
					{
						return spleenCenter;
					}
					set	
					{
						spleenCenter = value;
					}
				}
			}
		}
	}
}
