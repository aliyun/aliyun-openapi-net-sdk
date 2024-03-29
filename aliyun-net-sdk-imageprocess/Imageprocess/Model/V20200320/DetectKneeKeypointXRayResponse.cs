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
	public class DetectKneeKeypointXRayResponse : AcsResponse
	{

		private string requestId;

		private DetectKneeKeypointXRay_Data data;

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

		public DetectKneeKeypointXRay_Data Data
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

		public class DetectKneeKeypointXRay_Data
		{

			private string imageUrl;

			private string orgId;

			private string orgName;

			private List<DetectKneeKeypointXRay_KeyPointsItem> keyPoints;

			public string ImageUrl
			{
				get
				{
					return imageUrl;
				}
				set	
				{
					imageUrl = value;
				}
			}

			public string OrgId
			{
				get
				{
					return orgId;
				}
				set	
				{
					orgId = value;
				}
			}

			public string OrgName
			{
				get
				{
					return orgName;
				}
				set	
				{
					orgName = value;
				}
			}

			public List<DetectKneeKeypointXRay_KeyPointsItem> KeyPoints
			{
				get
				{
					return keyPoints;
				}
				set	
				{
					keyPoints = value;
				}
			}

			public class DetectKneeKeypointXRay_KeyPointsItem
			{

				private float? _value;

				private List<string> coordinates;

				private DetectKneeKeypointXRay_Tag tag;

				public float? _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
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

				public DetectKneeKeypointXRay_Tag Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public class DetectKneeKeypointXRay_Tag
				{

					private string direction;

					private string label;

					public string Direction
					{
						get
						{
							return direction;
						}
						set	
						{
							direction = value;
						}
					}

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}
				}
			}
		}
	}
}
