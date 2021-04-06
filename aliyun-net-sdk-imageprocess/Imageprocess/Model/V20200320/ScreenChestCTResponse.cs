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
	public class ScreenChestCTResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private ScreenChestCT_Data data;

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

		public ScreenChestCT_Data Data
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

		public class ScreenChestCT_Data
		{

			private ScreenChestCT_Covid covid;

			private ScreenChestCT_CACS cACS;

			private ScreenChestCT_LungNodule lungNodule;

			private ScreenChestCT_DetectRibFracture detectRibFracture;

			public ScreenChestCT_Covid Covid
			{
				get
				{
					return covid;
				}
				set	
				{
					covid = value;
				}
			}

			public ScreenChestCT_CACS CACS
			{
				get
				{
					return cACS;
				}
				set	
				{
					cACS = value;
				}
			}

			public ScreenChestCT_LungNodule LungNodule
			{
				get
				{
					return lungNodule;
				}
				set	
				{
					lungNodule = value;
				}
			}

			public ScreenChestCT_DetectRibFracture DetectRibFracture
			{
				get
				{
					return detectRibFracture;
				}
				set	
				{
					detectRibFracture = value;
				}
			}

			public class ScreenChestCT_Covid
			{

				private string newProbability;

				private string otherProbability;

				private string normalProbability;

				private string mask;

				private string lesionRatio;

				public string NewProbability
				{
					get
					{
						return newProbability;
					}
					set	
					{
						newProbability = value;
					}
				}

				public string OtherProbability
				{
					get
					{
						return otherProbability;
					}
					set	
					{
						otherProbability = value;
					}
				}

				public string NormalProbability
				{
					get
					{
						return normalProbability;
					}
					set	
					{
						normalProbability = value;
					}
				}

				public string Mask
				{
					get
					{
						return mask;
					}
					set	
					{
						mask = value;
					}
				}

				public string LesionRatio
				{
					get
					{
						return lesionRatio;
					}
					set	
					{
						lesionRatio = value;
					}
				}
			}

			public class ScreenChestCT_CACS
			{

				private string score;

				private string resultUrl;

				public string Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}

				public string ResultUrl
				{
					get
					{
						return resultUrl;
					}
					set	
					{
						resultUrl = value;
					}
				}
			}

			public class ScreenChestCT_LungNodule
			{

				private List<ScreenChestCT_Serie> series;

				public List<ScreenChestCT_Serie> Series
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

				public class ScreenChestCT_Serie
				{

					private string report;

					private string seriesInstanceUid;

					private List<ScreenChestCT_Element> elements;

					private List<string> origin;

					private List<string> spacing;

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

					public List<ScreenChestCT_Element> Elements
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

					public class ScreenChestCT_Element
					{

						private float? imageZ;

						private float? imageY;

						private float? imageX;

						private string lobe;

						private string category;

						private string lung;

						private float? meanValue;

						private float? volume;

						private float? confidence;

						private float? x;

						private float? y;

						private float? z;

						private string sOPInstanceUID;

						private float? diameter;

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
					}
				}
			}

			public class ScreenChestCT_DetectRibFracture
			{

				private string resultURL;

				private List<ScreenChestCT_DetectionsItem> detections;

				private List<string> origin1;

				private List<string> spacing2;

				public string ResultURL
				{
					get
					{
						return resultURL;
					}
					set	
					{
						resultURL = value;
					}
				}

				public List<ScreenChestCT_DetectionsItem> Detections
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

				public List<string> Origin1
				{
					get
					{
						return origin1;
					}
					set	
					{
						origin1 = value;
					}
				}

				public List<string> Spacing2
				{
					get
					{
						return spacing2;
					}
					set	
					{
						spacing2 = value;
					}
				}

				public class ScreenChestCT_DetectionsItem
				{

					private long? fractureCategory;

					private float? fractureConfidence;

					private string fractureLocation;

					private long? fractureSegment;

					private long? fractureId;

					private List<string> coordinateImage;

					private List<string> coordinates;

					public long? FractureCategory
					{
						get
						{
							return fractureCategory;
						}
						set	
						{
							fractureCategory = value;
						}
					}

					public float? FractureConfidence
					{
						get
						{
							return fractureConfidence;
						}
						set	
						{
							fractureConfidence = value;
						}
					}

					public string FractureLocation
					{
						get
						{
							return fractureLocation;
						}
						set	
						{
							fractureLocation = value;
						}
					}

					public long? FractureSegment
					{
						get
						{
							return fractureSegment;
						}
						set	
						{
							fractureSegment = value;
						}
					}

					public long? FractureId
					{
						get
						{
							return fractureId;
						}
						set	
						{
							fractureId = value;
						}
					}

					public List<string> CoordinateImage
					{
						get
						{
							return coordinateImage;
						}
						set	
						{
							coordinateImage = value;
						}
					}

					public List<string> Coordinates
					{
						get
						{
							return coordinates;
						}
						set	
						{
							coordinates = value;
						}
					}
				}
			}
		}
	}
}
