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
	public class RecognizeEntityResponse : AcsResponse
	{

		private int? code;

		private string message;

		private bool? success;

		private RecognizeEntity_Response response;

		public int? Code
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

		public RecognizeEntity_Response Response
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

		public class RecognizeEntity_Response
		{

			private bool? success;

			private string url;

			private string requestId;

			private string errorCode;

			private string errorMessage;

			private RecognizeEntity_Data data;

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

			public RecognizeEntity_Data Data
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

			public class RecognizeEntity_Data
			{

				private int? callSubModelApi;

				private string requestId;

				private int? useSubModelResult;

				private List<RecognizeEntity_Node> result;

				public int? CallSubModelApi
				{
					get
					{
						return callSubModelApi;
					}
					set	
					{
						callSubModelApi = value;
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

				public int? UseSubModelResult
				{
					get
					{
						return useSubModelResult;
					}
					set	
					{
						useSubModelResult = value;
					}
				}

				public List<RecognizeEntity_Node> Result
				{
					get
					{
						return result;
					}
					set	
					{
						result = value;
					}
				}

				public class RecognizeEntity_Node
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
