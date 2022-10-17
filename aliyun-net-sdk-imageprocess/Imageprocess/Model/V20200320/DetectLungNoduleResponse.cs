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
	public class DetectLungNoduleResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private DetectLungNodule_Data data;

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

		public DetectLungNodule_Data Data
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

		public class DetectLungNodule_Data
		{

			private List<DetectLungNodule_Serie> series;

			public List<DetectLungNodule_Serie> Series
			{
				get
				{
					return series;
				}
				set	
				{
					series = value;
				}
			}

			public class DetectLungNodule_Serie
			{

				private string seriesInstanceUid;

				private string report;

				private List<DetectLungNodule_Element> elements;

				private List<string> origin;

				private List<string> spacing;

				public string SeriesInstanceUid
				{
					get
					{
						return seriesInstanceUid;
					}
					set	
					{
						seriesInstanceUid = value;
					}
				}

				public string Report
				{
					get
					{
						return report;
					}
					set	
					{
						report = value;
					}
				}

				public List<DetectLungNodule_Element> Elements
				{
					get
					{
						return elements;
					}
					set	
					{
						elements = value;
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

				public class DetectLungNodule_Element
				{

					private float? z;

					private string lobe;

					private float? meanValue;

					private float? imageZ;

					private string lung;

					private float? confidence;

					private string sOPInstanceUID;

					private float? imageX;

					private float? y;

					private string category;

					private float? volume;

					private float? imageY;

					private float? diameter;

					private float? x;

					public float? Z
					{
						get
						{
							return z;
						}
						set	
						{
							z = value;
						}
					}

					public string Lobe
					{
						get
						{
							return lobe;
						}
						set	
						{
							lobe = value;
						}
					}

					public float? MeanValue
					{
						get
						{
							return meanValue;
						}
						set	
						{
							meanValue = value;
						}
					}

					public float? ImageZ
					{
						get
						{
							return imageZ;
						}
						set	
						{
							imageZ = value;
						}
					}

					public string Lung
					{
						get
						{
							return lung;
						}
						set	
						{
							lung = value;
						}
					}

					public float? Confidence
					{
						get
						{
							return confidence;
						}
						set	
						{
							confidence = value;
						}
					}

					public string SOPInstanceUID
					{
						get
						{
							return sOPInstanceUID;
						}
						set	
						{
							sOPInstanceUID = value;
						}
					}

					public float? ImageX
					{
						get
						{
							return imageX;
						}
						set	
						{
							imageX = value;
						}
					}

					public float? Y
					{
						get
						{
							return y;
						}
						set	
						{
							y = value;
						}
					}

					public string Category
					{
						get
						{
							return category;
						}
						set	
						{
							category = value;
						}
					}

					public float? Volume
					{
						get
						{
							return volume;
						}
						set	
						{
							volume = value;
						}
					}

					public float? ImageY
					{
						get
						{
							return imageY;
						}
						set	
						{
							imageY = value;
						}
					}

					public float? Diameter
					{
						get
						{
							return diameter;
						}
						set	
						{
							diameter = value;
						}
					}

					public float? X
					{
						get
						{
							return x;
						}
						set	
						{
							x = value;
						}
					}
				}
			}
		}
	}
}
