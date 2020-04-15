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
	public class PredictCategoryResponse : AcsResponse
	{

		private int? code;

		private string message;

		private bool? success;

		private PredictCategory_Response response;

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

		public PredictCategory_Response Response
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

		public class PredictCategory_Response
		{

			private bool? success;

			private string url;

			private string requestId;

			private string errorCode;

			private string errorMessage;

			private List<PredictCategory_Node> data;

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

			public List<PredictCategory_Node> Data
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

			public class PredictCategory_Node
			{

				private string cateId;

				private PredictCategory_Category category;

				public string CateId
				{
					get
					{
						return cateId;
					}
					set	
					{
						cateId = value;
					}
				}

				public PredictCategory_Category Category
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

				public class PredictCategory_Category
				{

					private string cateLevelFOURName;

					private int? cateLevelTwoId;

					private int? cateLevelOneId;

					private string cateLevelOneName;

					private int? cateLevelFourId;

					private int? cateLevel;

					private int? cateLevelThreeId;

					private int? cateLevelFiveId;

					private string cateLevelFiveName;

					private string cateName;

					private string cateLevelTwoName;

					private float? score;

					private int? cateId;

					private string cateLevelThreeName;

					public string CateLevelFOURName
					{
						get
						{
							return cateLevelFOURName;
						}
						set	
						{
							cateLevelFOURName = value;
						}
					}

					public int? CateLevelTwoId
					{
						get
						{
							return cateLevelTwoId;
						}
						set	
						{
							cateLevelTwoId = value;
						}
					}

					public int? CateLevelOneId
					{
						get
						{
							return cateLevelOneId;
						}
						set	
						{
							cateLevelOneId = value;
						}
					}

					public string CateLevelOneName
					{
						get
						{
							return cateLevelOneName;
						}
						set	
						{
							cateLevelOneName = value;
						}
					}

					public int? CateLevelFourId
					{
						get
						{
							return cateLevelFourId;
						}
						set	
						{
							cateLevelFourId = value;
						}
					}

					public int? CateLevel
					{
						get
						{
							return cateLevel;
						}
						set	
						{
							cateLevel = value;
						}
					}

					public int? CateLevelThreeId
					{
						get
						{
							return cateLevelThreeId;
						}
						set	
						{
							cateLevelThreeId = value;
						}
					}

					public int? CateLevelFiveId
					{
						get
						{
							return cateLevelFiveId;
						}
						set	
						{
							cateLevelFiveId = value;
						}
					}

					public string CateLevelFiveName
					{
						get
						{
							return cateLevelFiveName;
						}
						set	
						{
							cateLevelFiveName = value;
						}
					}

					public string CateName
					{
						get
						{
							return cateName;
						}
						set	
						{
							cateName = value;
						}
					}

					public string CateLevelTwoName
					{
						get
						{
							return cateLevelTwoName;
						}
						set	
						{
							cateLevelTwoName = value;
						}
					}

					public float? Score
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

					public int? CateId
					{
						get
						{
							return cateId;
						}
						set	
						{
							cateId = value;
						}
					}

					public string CateLevelThreeName
					{
						get
						{
							return cateLevelThreeName;
						}
						set	
						{
							cateLevelThreeName = value;
						}
					}
				}
			}
		}
	}
}
