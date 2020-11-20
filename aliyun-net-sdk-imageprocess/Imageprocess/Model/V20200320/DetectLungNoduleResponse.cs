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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
	public class DetectLungNoduleResponse : AcsResponse
	{

		private string requestId;

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

					private string category;

					private float? confidence;

					private float? diameter;

					private string lobe;

					private string lung;

					private float? x;

					private float? z;

					private float? y;

					private float? imageX;

					private float? imageY;

					private float? imageZ;

					private string sOPInstanceUID;

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
				}
			}
		}
	}
}
