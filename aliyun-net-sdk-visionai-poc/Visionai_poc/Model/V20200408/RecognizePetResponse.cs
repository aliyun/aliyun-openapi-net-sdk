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

namespace Aliyun.Acs.visionai_poc.Model.V20200408
{
	public class RecognizePetResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private RecognizePet_Response response;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public RecognizePet_Response Response
		{
			get
			{
				return response;
			}
			set	
			{
				response = value;
			}
		}

		public class RecognizePet_Response
		{

			private bool? success;

			private string url;

			private string requestId;

			private string errorCode;

			private string errorMessage;

			private RecognizePet_Data data;

			public bool? Success
			{
				get
				{
					return success;
				}
				set	
				{
					success = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
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

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

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

			public RecognizePet_Data Data
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

			public class RecognizePet_Data
			{

				private string external;

				private string modelName;

				private string confidence;

				private string prop;

				private string name;

				private string picUrl;

				private string sptId;

				private string roid;

				private string tips;

				private string description;

				private string predictRes;

				private List<RecognizePet_Node> predictability;

				public string External
				{
					get
					{
						return external;
					}
					set	
					{
						external = value;
					}
				}

				public string ModelName
				{
					get
					{
						return modelName;
					}
					set	
					{
						modelName = value;
					}
				}

				public string Confidence
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

				public string Prop
				{
					get
					{
						return prop;
					}
					set	
					{
						prop = value;
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

				public string PicUrl
				{
					get
					{
						return picUrl;
					}
					set	
					{
						picUrl = value;
					}
				}

				public string SptId
				{
					get
					{
						return sptId;
					}
					set	
					{
						sptId = value;
					}
				}

				public string Roid
				{
					get
					{
						return roid;
					}
					set	
					{
						roid = value;
					}
				}

				public string Tips
				{
					get
					{
						return tips;
					}
					set	
					{
						tips = value;
					}
				}

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string PredictRes
				{
					get
					{
						return predictRes;
					}
					set	
					{
						predictRes = value;
					}
				}

				public List<RecognizePet_Node> Predictability
				{
					get
					{
						return predictability;
					}
					set	
					{
						predictability = value;
					}
				}

				public class RecognizePet_Node
				{

					private string score;

					private string tag;

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

					public string Tag
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
				}
			}
		}
	}
}
