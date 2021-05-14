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

		private string requestId;

		private string code;

		private string message;

		private ScreenChestCT_Data data;

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

			private string errorMessage;

			private ScreenChestCT_LungNodule lungNodule;

			private ScreenChestCT_CACS cACS;

			private ScreenChestCT_Covid covid;

			private ScreenChestCT_DetectRibFracture detectRibFracture;

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
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

					private string seriesInstanceUid;

					private string report;

					private List<ScreenChestCT_Element> elements;

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

						private string lobe;

						private float? meanValue;

						private string lung;

						private float? confidence;

						private string sOPInstanceUID;

						private string category;

						private float? volume;

						private float? diameter;

						private float? x;

						private float? y;

						private float? z;

						private float? imageX;

						private float? imageY;

						private float? imageZ;

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
					}
				}
			}

			public class ScreenChestCT_CACS
			{

				private string resultUrl;

				private string score;

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
			}

			public class ScreenChestCT_Covid
			{

				private string normalProbability;

				private string newProbability;

				private string lesionRatio;

				private string otherProbability;

				private string mask;

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
			}

			public class ScreenChestCT_DetectRibFracture
			{

				private string resultURL;

				private List<ScreenChestCT_DetectionsItem> detections;

				private List<string> spacing1;

				private List<string> origin2;

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

				public List<string> Spacing1
				{
					get
					{
						return spacing1;
					}
					set	
					{
						spacing1 = value;
					}
				}

				public List<string> Origin2
				{
					get
					{
						return origin2;
					}
					set	
					{
						origin2 = value;
					}
				}

				public class ScreenChestCT_DetectionsItem
				{

					private long? fractureId;

					private float? fractureConfidence;

					private long? fractureCategory;

					private string fractureLocation;

					private long? fractureSegment;

					private List<string> coordinates;

					private List<string> coordinateImage;

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
				}
			}
		}
	}
}
