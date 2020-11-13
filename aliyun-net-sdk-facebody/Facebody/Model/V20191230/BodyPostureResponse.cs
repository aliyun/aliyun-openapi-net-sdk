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
	public class BodyPostureResponse : AcsResponse
	{

		private string requestId;

		private BodyPosture_Data data;

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

		public BodyPosture_Data Data
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

		public class BodyPosture_Data
		{

			private List<BodyPosture_Output> outputs;

			private BodyPosture_MetaObject metaObject;

			public List<BodyPosture_Output> Outputs
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

			public BodyPosture_MetaObject MetaObject
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

			public class BodyPosture_Output
			{

				private int? humanCount;

				private List<BodyPosture_Result> results;

				public int? HumanCount
				{
					get
					{
						return humanCount;
					}
					set	
					{
						humanCount = value;
					}
				}

				public List<BodyPosture_Result> Results
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

				public class BodyPosture_Result
				{

					private List<BodyPosture_Body> bodies;

					public List<BodyPosture_Body> Bodies
					{
						get
						{
							return bodies;
						}
						set	
						{
							bodies = value;
						}
					}

					public class BodyPosture_Body
					{

						private float? confident;

						private string label;

						private List<BodyPosture_Position> positions;

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

						public List<BodyPosture_Position> Positions
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

						public class BodyPosture_Position
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
				}
			}

			public class BodyPosture_MetaObject
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
