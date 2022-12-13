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
	public class DetectRibFractureResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private DetectRibFracture_Data data;

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

		public DetectRibFracture_Data Data
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

		public class DetectRibFracture_Data
		{

			private string resultURL;

			private List<DetectRibFracture_DetectionsItem> detections;

			private List<string> origin;

			private List<string> spacing;

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

			public List<DetectRibFracture_DetectionsItem> Detections
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

			public class DetectRibFracture_DetectionsItem
			{

				private int? fractureId;

				private float? fractureConfidence;

				private string fractureCategory;

				private string fractureLocation;

				private long? fractureSegment;

				private string fracSOPInstanceUID;

				private List<string> coordinates;

				private List<string> coordinateImage;

				public int? FractureId
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

				public string FractureCategory
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

				public string FracSOPInstanceUID
				{
					get
					{
						return fracSOPInstanceUID;
					}
					set	
					{
						fracSOPInstanceUID = value;
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
