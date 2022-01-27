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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class GetTypeListResponse : AcsResponse
	{

		private string requestId;

		private GetTypeList_Fee fee;

		private GetTypeList_InInvoice inInvoice;

		private GetTypeList_OutInvoice outInvoice;

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

		public GetTypeList_Fee Fee
		{
			get
			{
				return fee;
			}
			set	
			{
				fee = value;
			}
		}

		public GetTypeList_InInvoice InInvoice
		{
			get
			{
				return inInvoice;
			}
			set	
			{
				inInvoice = value;
			}
		}

		public GetTypeList_OutInvoice OutInvoice
		{
			get
			{
				return outInvoice;
			}
			set	
			{
				outInvoice = value;
			}
		}

		public class GetTypeList_Fee
		{

			private List<GetTypeList_KindEnum> kind;

			private List<GetTypeList_PayMethodEnum> payMethod;

			private List<GetTypeList_UseEnum> use;

			public List<GetTypeList_KindEnum> Kind
			{
				get
				{
					return kind;
				}
				set	
				{
					kind = value;
				}
			}

			public List<GetTypeList_PayMethodEnum> PayMethod
			{
				get
				{
					return payMethod;
				}
				set	
				{
					payMethod = value;
				}
			}

			public List<GetTypeList_UseEnum> Use
			{
				get
				{
					return use;
				}
				set	
				{
					use = value;
				}
			}

			public class GetTypeList_KindEnum
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

			public class GetTypeList_PayMethodEnum
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

			public class GetTypeList_UseEnum
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

		public class GetTypeList_InInvoice
		{

			private List<GetTypeList_BuyMethodEnum> buyMethod;

			private List<GetTypeList_FixedAssetTypeEnum> fixedAssetType;

			private List<GetTypeList_BuyTargetEnum> buyTarget;

			public List<GetTypeList_BuyMethodEnum> BuyMethod
			{
				get
				{
					return buyMethod;
				}
				set	
				{
					buyMethod = value;
				}
			}

			public List<GetTypeList_FixedAssetTypeEnum> FixedAssetType
			{
				get
				{
					return fixedAssetType;
				}
				set	
				{
					fixedAssetType = value;
				}
			}

			public List<GetTypeList_BuyTargetEnum> BuyTarget
			{
				get
				{
					return buyTarget;
				}
				set	
				{
					buyTarget = value;
				}
			}

			public class GetTypeList_BuyMethodEnum
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

			public class GetTypeList_FixedAssetTypeEnum
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

			public class GetTypeList_BuyTargetEnum
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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

		public class GetTypeList_OutInvoice
		{

			private List<GetTypeList_ShellMethodEnum> shellMethod;

			public List<GetTypeList_ShellMethodEnum> ShellMethod
			{
				get
				{
					return shellMethod;
				}
				set	
				{
					shellMethod = value;
				}
			}

			public class GetTypeList_ShellMethodEnum
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
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
}
