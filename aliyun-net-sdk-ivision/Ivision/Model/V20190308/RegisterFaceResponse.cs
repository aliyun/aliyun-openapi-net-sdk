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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class RegisterFaceResponse : AcsResponse
	{

		private string requestId;

		private string groupId;

		private List<RegisterFace_Face> faces;

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

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
			}
		}

		public List<RegisterFace_Face> Faces
		{
			get
			{
				return faces;
			}
			set	
			{
				faces = value;
			}
		}

		public class RegisterFace_Face
		{

			private string faceToken;

			private RegisterFace_Rect rect;

			public string FaceToken
			{
				get
				{
					return faceToken;
				}
				set	
				{
					faceToken = value;
				}
			}

			public RegisterFace_Rect Rect
			{
				get
				{
					return rect;
				}
				set	
				{
					rect = value;
				}
			}

			public class RegisterFace_Rect
			{

				private int? top;

				private int? width;

				private int? height;

				private int? left;

				public int? Top
				{
					get
					{
						return top;
					}
					set	
					{
						top = value;
					}
				}

				public int? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public int? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public int? Left
				{
					get
					{
						return left;
					}
					set	
					{
						left = value;
					}
				}
			}
		}
	}
}
