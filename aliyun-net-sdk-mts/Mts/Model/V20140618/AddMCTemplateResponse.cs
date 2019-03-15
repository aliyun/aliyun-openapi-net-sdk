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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class AddMCTemplateResponse : AcsResponse
	{

		private string requestId;

		private AddMCTemplate_Template template;

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

		public AddMCTemplate_Template Template
		{
			get
			{
				return template;
			}
			set	
			{
				template = value;
			}
		}

		public class AddMCTemplate_Template
		{

			private string templateId;

			private string name;

			private string porn;

			private string terrorism;

			private string politics;

			private string ad;

			private string qrcode;

			private string live;

			private string logo;

			private string abuse;

			private string contraband;

			private string spam;

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
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

			public string Porn
			{
				get
				{
					return porn;
				}
				set	
				{
					porn = value;
				}
			}

			public string Terrorism
			{
				get
				{
					return terrorism;
				}
				set	
				{
					terrorism = value;
				}
			}

			public string Politics
			{
				get
				{
					return politics;
				}
				set	
				{
					politics = value;
				}
			}

			public string Ad
			{
				get
				{
					return ad;
				}
				set	
				{
					ad = value;
				}
			}

			public string Qrcode
			{
				get
				{
					return qrcode;
				}
				set	
				{
					qrcode = value;
				}
			}

			public string Live
			{
				get
				{
					return live;
				}
				set	
				{
					live = value;
				}
			}

			public string Logo
			{
				get
				{
					return logo;
				}
				set	
				{
					logo = value;
				}
			}

			public string Abuse
			{
				get
				{
					return abuse;
				}
				set	
				{
					abuse = value;
				}
			}

			public string Contraband
			{
				get
				{
					return contraband;
				}
				set	
				{
					contraband = value;
				}
			}

			public string Spam
			{
				get
				{
					return spam;
				}
				set	
				{
					spam = value;
				}
			}
		}
	}
}
