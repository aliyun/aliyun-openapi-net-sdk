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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeCompanyTemplateAttributeResponse : AcsResponse
	{

		private string requestId;

		private string errorMessage;

		private bool? success;

		private string errorCode;

		private string code;

		private string message;

		private string dynamicMessage;

		private string dynamicCode;

		private List<DescribeCompanyTemplateAttribute_SelectItemInfo> categoryField;

		private List<DescribeCompanyTemplateAttribute_SelectItemInfo> fontType;

		private List<DescribeCompanyTemplateAttribute_SelectItemInfo> deviceType;

		private List<DescribeCompanyTemplateAttribute_SelectItemInfo> templateType;

		private List<DescribeCompanyTemplateAttribute_SelectItemInfo> sizeType;

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

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public List<DescribeCompanyTemplateAttribute_SelectItemInfo> CategoryField
		{
			get
			{
				return categoryField;
			}
			set	
			{
				categoryField = value;
			}
		}

		public List<DescribeCompanyTemplateAttribute_SelectItemInfo> FontType
		{
			get
			{
				return fontType;
			}
			set	
			{
				fontType = value;
			}
		}

		public List<DescribeCompanyTemplateAttribute_SelectItemInfo> DeviceType
		{
			get
			{
				return deviceType;
			}
			set	
			{
				deviceType = value;
			}
		}

		public List<DescribeCompanyTemplateAttribute_SelectItemInfo> TemplateType
		{
			get
			{
				return templateType;
			}
			set	
			{
				templateType = value;
			}
		}

		public List<DescribeCompanyTemplateAttribute_SelectItemInfo> SizeType
		{
			get
			{
				return sizeType;
			}
			set	
			{
				sizeType = value;
			}
		}

		public class DescribeCompanyTemplateAttribute_SelectItemInfo
		{

			private string label;

			private string _value;

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
		}
	}
}
