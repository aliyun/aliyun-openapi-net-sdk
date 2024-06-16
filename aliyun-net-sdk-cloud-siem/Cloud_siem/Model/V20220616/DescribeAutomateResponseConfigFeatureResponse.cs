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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeAutomateResponseConfigFeatureResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private List<DescribeAutomateResponseConfigFeature_DataItem> data;

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

		public List<DescribeAutomateResponseConfigFeature_DataItem> Data
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

		public class DescribeAutomateResponseConfigFeature_DataItem
		{

			private string feature;

			private string dataType;

			private List<DescribeAutomateResponseConfigFeature_SupportOperator> supportOperators;

			private List<DescribeAutomateResponseConfigFeature_RightValueEnum> rightValueEnums;

			public string Feature
			{
				get
				{
					return feature;
				}
				set	
				{
					feature = value;
				}
			}

			public string DataType
			{
				get
				{
					return dataType;
				}
				set	
				{
					dataType = value;
				}
			}

			public List<DescribeAutomateResponseConfigFeature_SupportOperator> SupportOperators
			{
				get
				{
					return supportOperators;
				}
				set	
				{
					supportOperators = value;
				}
			}

			public List<DescribeAutomateResponseConfigFeature_RightValueEnum> RightValueEnums
			{
				get
				{
					return rightValueEnums;
				}
				set	
				{
					rightValueEnums = value;
				}
			}

			public class DescribeAutomateResponseConfigFeature_SupportOperator
			{

				private bool? hasRightValue;

				private string _operator;

				private string operatorName;

				private string operatorDescCn;

				private string operatorDescEn;

				private string supportDataType;

				private int? index;

				private List<string> supportTag;

				public bool? HasRightValue
				{
					get
					{
						return hasRightValue;
					}
					set	
					{
						hasRightValue = value;
					}
				}

				public string _Operator
				{
					get
					{
						return _operator;
					}
					set	
					{
						_operator = value;
					}
				}

				public string OperatorName
				{
					get
					{
						return operatorName;
					}
					set	
					{
						operatorName = value;
					}
				}

				public string OperatorDescCn
				{
					get
					{
						return operatorDescCn;
					}
					set	
					{
						operatorDescCn = value;
					}
				}

				public string OperatorDescEn
				{
					get
					{
						return operatorDescEn;
					}
					set	
					{
						operatorDescEn = value;
					}
				}

				public string SupportDataType
				{
					get
					{
						return supportDataType;
					}
					set	
					{
						supportDataType = value;
					}
				}

				public int? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public List<string> SupportTag
				{
					get
					{
						return supportTag;
					}
					set	
					{
						supportTag = value;
					}
				}
			}

			public class DescribeAutomateResponseConfigFeature_RightValueEnum
			{

				private string _value;

				private string valueMds;

				public string _Value
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

				public string ValueMds
				{
					get
					{
						return valueMds;
					}
					set	
					{
						valueMds = value;
					}
				}
			}
		}
	}
}
