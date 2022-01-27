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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBInitializeVariableResponse : AcsResponse
	{

		private string requestId;

		private string dBType;

		private string dBVersion;

		private List<DescribeDBInitializeVariable_Variable> variables;

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

		public string DBType
		{
			get
			{
				return dBType;
			}
			set	
			{
				dBType = value;
			}
		}

		public string DBVersion
		{
			get
			{
				return dBVersion;
			}
			set	
			{
				dBVersion = value;
			}
		}

		public List<DescribeDBInitializeVariable_Variable> Variables
		{
			get
			{
				return variables;
			}
			set	
			{
				variables = value;
			}
		}

		public class DescribeDBInitializeVariable_Variable
		{

			private string charset;

			private string collate;

			private string ctype;

			public string Charset
			{
				get
				{
					return charset;
				}
				set	
				{
					charset = value;
				}
			}

			public string Collate
			{
				get
				{
					return collate;
				}
				set	
				{
					collate = value;
				}
			}

			public string Ctype
			{
				get
				{
					return ctype;
				}
				set	
				{
					ctype = value;
				}
			}
		}
	}
}
