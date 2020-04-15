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
	public class RecognizeLabelResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private RecognizeLabel_Response response;

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

		public RecognizeLabel_Response Response
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

		public class RecognizeLabel_Response
		{

			private bool? success;

			private string url;

			private string requestId;

			private string errorCode;

			private string errorMessage;

			private RecognizeLabel_Data data;

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

			public RecognizeLabel_Data Data
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

			public class RecognizeLabel_Data
			{

				private List<RecognizeLabel_Node> objects;

				public List<RecognizeLabel_Node> Objects
				{
					get
					{
						return objects;
					}
					set	
					{
						objects = value;
					}
				}

				public class RecognizeLabel_Node
				{

					private RecognizeLabel_PropertiesResults propertiesResults;

					public RecognizeLabel_PropertiesResults PropertiesResults
					{
						get
						{
							return propertiesResults;
						}
						set	
						{
							propertiesResults = value;
						}
					}

					public class RecognizeLabel_PropertiesResults
					{

						private string propertyId;

						private string propertyName;

						private List<RecognizeLabel_SubNode> values;

						public string PropertyId
						{
							get
							{
								return propertyId;
							}
							set	
							{
								propertyId = value;
							}
						}

						public string PropertyName
						{
							get
							{
								return propertyName;
							}
							set	
							{
								propertyName = value;
							}
						}

						public List<RecognizeLabel_SubNode> Values
						{
							get
							{
								return values;
							}
							set	
							{
								values = value;
							}
						}

						public class RecognizeLabel_SubNode
						{

							private int? probability;

							private string valueId;

							private string valueName;

							public int? Probability
							{
								get
								{
									return probability;
								}
								set	
								{
									probability = value;
								}
							}

							public string ValueId
							{
								get
								{
									return valueId;
								}
								set	
								{
									valueId = value;
								}
							}

							public string ValueName
							{
								get
								{
									return valueName;
								}
								set	
								{
									valueName = value;
								}
							}
						}
					}
				}
			}
		}
	}
}
