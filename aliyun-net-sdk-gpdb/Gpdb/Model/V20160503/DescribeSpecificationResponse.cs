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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeSpecificationResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSpecification_StorageNoticeItem> storageNotice;

		private List<DescribeSpecification_DBInstanceClassItem> dBInstanceClass;

		private List<DescribeSpecification_DBInstanceGroupCountItem> dBInstanceGroupCount;

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

		public List<DescribeSpecification_StorageNoticeItem> StorageNotice
		{
			get
			{
				return storageNotice;
			}
			set	
			{
				storageNotice = value;
			}
		}

		public List<DescribeSpecification_DBInstanceClassItem> DBInstanceClass
		{
			get
			{
				return dBInstanceClass;
			}
			set	
			{
				dBInstanceClass = value;
			}
		}

		public List<DescribeSpecification_DBInstanceGroupCountItem> DBInstanceGroupCount
		{
			get
			{
				return dBInstanceGroupCount;
			}
			set	
			{
				dBInstanceGroupCount = value;
			}
		}

		public class DescribeSpecification_StorageNoticeItem
		{

			private string _value;

			private string text;

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

			public string Text
			{
				get
				{
					return text;
				}
				set	
				{
					text = value;
				}
			}
		}

		public class DescribeSpecification_DBInstanceClassItem
		{

			private string _value;

			private string text;

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

			public string Text
			{
				get
				{
					return text;
				}
				set	
				{
					text = value;
				}
			}
		}

		public class DescribeSpecification_DBInstanceGroupCountItem
		{

			private string _value;

			private string text;

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

			public string Text
			{
				get
				{
					return text;
				}
				set	
				{
					text = value;
				}
			}
		}
	}
}
