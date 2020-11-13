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

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class HandPostureResponse : AcsResponse
	{

		private string requestId;

		private HandPosture_Data data;

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

		public HandPosture_Data Data
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

		public class HandPosture_Data
		{

			private List<HandPosture_Output> outputs;

			private HandPosture_MetaObject metaObject;

			public List<HandPosture_Output> Outputs
			{
				get
				{
					return outputs;
				}
				set	
				{
					outputs = value;
				}
			}

			public HandPosture_MetaObject MetaObject
			{
				get
				{
					return metaObject;
				}
				set	
				{
					metaObject = value;
				}
			}

			public class HandPosture_Output
			{

				private int? handCount;

				private List<HandPosture_Result> results;

				public int? HandCount
				{
					get
					{
						return handCount;
					}
					set	
					{
						handCount = value;
					}
				}

				public List<HandPosture_Result> Results
				{
					get
					{
						return results;
					}
					set	
					{
						results = value;
					}
				}

				public class HandPosture_Result
				{

					private HandPosture_Box box;

					private HandPosture_Hands hands;

					public HandPosture_Box Box
					{
						get
						{
							return box;
						}
						set	
						{
							box = value;
						}
					}

					public HandPosture_Hands Hands
					{
						get
						{
							return hands;
						}
						set	
						{
							hands = value;
						}
					}

					public class HandPosture_Box
					{

						private float? confident;

						private List<HandPosture_Position> positions;

						public float? Confident
						{
							get
							{
								return confident;
							}
							set	
							{
								confident = value;
							}
						}

						public List<HandPosture_Position> Positions
						{
							get
							{
								return positions;
							}
							set	
							{
								positions = value;
							}
						}

						public class HandPosture_Position
						{

							private List<string> points;

							public List<string> Points
							{
								get
								{
									return points;
								}
								set	
								{
									points = value;
								}
							}
						}
					}

					public class HandPosture_Hands
					{

						private float? confident;

						private List<HandPosture_KeyPoint> keyPoints;

						public float? Confident
						{
							get
							{
								return confident;
							}
							set	
							{
								confident = value;
							}
						}

						public List<HandPosture_KeyPoint> KeyPoints
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

						public class HandPosture_KeyPoint
						{

							private string label;

							private List<HandPosture_Position2> positions1;

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

							public List<HandPosture_Position2> Positions1
							{
								get
								{
									return positions1;
								}
								set	
								{
									positions1 = value;
								}
							}

							public class HandPosture_Position2
							{

								private List<string> points3;

								public List<string> Points3
								{
									get
									{
										return points3;
									}
									set	
									{
										points3 = value;
									}
								}
							}
						}
					}
				}
			}

			public class HandPosture_MetaObject
			{

				private int? height;

				private int? width;

				public int? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public int? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}
			}
		}
	}
}
