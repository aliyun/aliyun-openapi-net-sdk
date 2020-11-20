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
	public class RecognizePublicFaceResponse : AcsResponse
	{

		private string requestId;

		private RecognizePublicFace_Data data;

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

		public RecognizePublicFace_Data Data
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

		public class RecognizePublicFace_Data
		{

			private List<RecognizePublicFace_Element> elements;

			public List<RecognizePublicFace_Element> Elements
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

			public class RecognizePublicFace_Element
			{

				private string taskId;

				private string imageURL;

				private List<RecognizePublicFace_Result> results;

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

				public List<RecognizePublicFace_Result> Results
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

				public class RecognizePublicFace_Result
				{

					private string label;

					private string suggestion;

					private float? rate;

					private List<RecognizePublicFace_SubResult> subResults;

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

					public List<RecognizePublicFace_SubResult> SubResults
					{
						get
						{
							return subResults;
						}
						set	
						{
							subResults = value;
						}
					}

					public class RecognizePublicFace_SubResult
					{

						private float? h;

						private float? w;

						private float? x;

						private float? y;

						private List<RecognizePublicFace_Face> faces;

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

						public List<RecognizePublicFace_Face> Faces
						{
							get
							{
								return faces;
							}
							set	
							{
								faces = value;
							}
						}

						public class RecognizePublicFace_Face
						{

							private string id;

							private string name;

							private float? rate;

							public string Id
							{
								get
								{
									return id;
								}
								set	
								{
									id = value;
								}
							}

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
						}
					}
				}
			}
		}
	}
}
