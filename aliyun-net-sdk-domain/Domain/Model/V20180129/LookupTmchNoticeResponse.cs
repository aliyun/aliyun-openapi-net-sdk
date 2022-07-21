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

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class LookupTmchNoticeResponse : AcsResponse
	{

		private string requestId;

		private string label;

		private long? id;

		private string notBefore;

		private string notAfter;

		private List<LookupTmchNotice_Claim> claims;

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

		public long? Id
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

		public string NotBefore
		{
			get
			{
				return notBefore;
			}
			set	
			{
				notBefore = value;
			}
		}

		public string NotAfter
		{
			get
			{
				return notAfter;
			}
			set	
			{
				notAfter = value;
			}
		}

		public List<LookupTmchNotice_Claim> Claims
		{
			get
			{
				return claims;
			}
			set	
			{
				claims = value;
			}
		}

		public class LookupTmchNotice_Claim
		{

			private string goodsAndServices;

			private string markName;

			private List<LookupTmchNotice_Contact> contacts;

			private List<LookupTmchNotice_ClassDesc> classDescs;

			private List<LookupTmchNotice_Holder> holders;

			private LookupTmchNotice_JurDesc jurDesc;

			public string GoodsAndServices
			{
				get
				{
					return goodsAndServices;
				}
				set	
				{
					goodsAndServices = value;
				}
			}

			public string MarkName
			{
				get
				{
					return markName;
				}
				set	
				{
					markName = value;
				}
			}

			public List<LookupTmchNotice_Contact> Contacts
			{
				get
				{
					return contacts;
				}
				set	
				{
					contacts = value;
				}
			}

			public List<LookupTmchNotice_ClassDesc> ClassDescs
			{
				get
				{
					return classDescs;
				}
				set	
				{
					classDescs = value;
				}
			}

			public List<LookupTmchNotice_Holder> Holders
			{
				get
				{
					return holders;
				}
				set	
				{
					holders = value;
				}
			}

			public LookupTmchNotice_JurDesc JurDesc
			{
				get
				{
					return jurDesc;
				}
				set	
				{
					jurDesc = value;
				}
			}

			public class LookupTmchNotice_Contact
			{

				private string type;

				private string voice;

				private string email;

				private string fax;

				private string org;

				private string name;

				private LookupTmchNotice_Addr addr;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string Voice
				{
					get
					{
						return voice;
					}
					set	
					{
						voice = value;
					}
				}

				public string Email
				{
					get
					{
						return email;
					}
					set	
					{
						email = value;
					}
				}

				public string Fax
				{
					get
					{
						return fax;
					}
					set	
					{
						fax = value;
					}
				}

				public string Org
				{
					get
					{
						return org;
					}
					set	
					{
						org = value;
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

				public LookupTmchNotice_Addr Addr
				{
					get
					{
						return addr;
					}
					set	
					{
						addr = value;
					}
				}

				public class LookupTmchNotice_Addr
				{

					private string cc;

					private string sp;

					private string pc;

					private string city;

					private List<string> street;

					public string Cc
					{
						get
						{
							return cc;
						}
						set	
						{
							cc = value;
						}
					}

					public string Sp
					{
						get
						{
							return sp;
						}
						set	
						{
							sp = value;
						}
					}

					public string Pc
					{
						get
						{
							return pc;
						}
						set	
						{
							pc = value;
						}
					}

					public string City
					{
						get
						{
							return city;
						}
						set	
						{
							city = value;
						}
					}

					public List<string> Street
					{
						get
						{
							return street;
						}
						set	
						{
							street = value;
						}
					}
				}
			}

			public class LookupTmchNotice_ClassDesc
			{

				private int? classNum;

				private string desc;

				public int? ClassNum
				{
					get
					{
						return classNum;
					}
					set	
					{
						classNum = value;
					}
				}

				public string Desc
				{
					get
					{
						return desc;
					}
					set	
					{
						desc = value;
					}
				}
			}

			public class LookupTmchNotice_Holder
			{

				private string entitlement;

				private string org;

				private LookupTmchNotice_Addr1 addr1;

				public string Entitlement
				{
					get
					{
						return entitlement;
					}
					set	
					{
						entitlement = value;
					}
				}

				public string Org
				{
					get
					{
						return org;
					}
					set	
					{
						org = value;
					}
				}

				public LookupTmchNotice_Addr1 Addr1
				{
					get
					{
						return addr1;
					}
					set	
					{
						addr1 = value;
					}
				}

				public class LookupTmchNotice_Addr1
				{

					private string cc;

					private string sp;

					private string pc;

					private string city;

					private List<string> street2;

					public string Cc
					{
						get
						{
							return cc;
						}
						set	
						{
							cc = value;
						}
					}

					public string Sp
					{
						get
						{
							return sp;
						}
						set	
						{
							sp = value;
						}
					}

					public string Pc
					{
						get
						{
							return pc;
						}
						set	
						{
							pc = value;
						}
					}

					public string City
					{
						get
						{
							return city;
						}
						set	
						{
							city = value;
						}
					}

					public List<string> Street2
					{
						get
						{
							return street2;
						}
						set	
						{
							street2 = value;
						}
					}
				}
			}

			public class LookupTmchNotice_JurDesc
			{

				private string jurCC;

				private string desc;

				public string JurCC
				{
					get
					{
						return jurCC;
					}
					set	
					{
						jurCC = value;
					}
				}

				public string Desc
				{
					get
					{
						return desc;
					}
					set	
					{
						desc = value;
					}
				}
			}
		}
	}
}
