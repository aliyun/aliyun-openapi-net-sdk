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

namespace Aliyun.Acs.imagerecog.Model.V20190930
{
	public class RecognizeLogoResponse : AcsResponse
	{

		private string requestId;

		private RecognizeLogo_Data data;

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

		public RecognizeLogo_Data Data
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

		public class RecognizeLogo_Data
		{

			private List<RecognizeLogo_Element> elements;

			public List<RecognizeLogo_Element> Elements
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

			public class RecognizeLogo_Element
			{

				private string taskId;

				private string imageURL;

				private List<RecognizeLogo_Result> results;

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
					}
				}

				public string ImageURL
				{
					get
					{
						return imageURL;
					}
					set	
					{
						imageURL = value;
					}
				}

				public List<RecognizeLogo_Result> Results
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

				public class RecognizeLogo_Result
				{

					private string label;

					private string suggestion;

					private float? rate;

					private List<RecognizeLogo_LogoData> logosData;

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

					public string Suggestion
					{
						get
						{
							return suggestion;
						}
						set	
						{
							suggestion = value;
						}
					}

					public float? Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

					public List<RecognizeLogo_LogoData> LogosData
					{
						get
						{
							return logosData;
						}
						set	
						{
							logosData = value;
						}
					}

					public class RecognizeLogo_LogoData
					{

						private string name;

						private string type;

						private float? x;

						private float? y;

						private float? h;

						private float? w;

						public string Name
						{
							get
							{
								return name;
							}
							set	
							{
								name = value;
							}
						}

						public string Type
						{
							get
							{
								return type;
							}
							set	
							{
								type = value;
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

						public float? H
						{
							get
							{
								return h;
							}
							set	
							{
								h = value;
							}
						}

						public float? W
						{
							get
							{
								return w;
							}
							set	
							{
								w = value;
							}
						}
					}
				}
			}
		}
	}
}
